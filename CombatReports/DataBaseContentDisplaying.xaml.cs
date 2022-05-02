using CombatReports.Business.Services.Interfaces;
using CombatReports.Data.Models;
using CombatReports.Helpers;
using CombatReports.DialogWindows;
using System;
using System.IO;
using System.Windows;
using Constant = CombatReports.Constants.Constants;

namespace CombatReports
{
    public partial class DataBaseContentDisplaying : Window
    {
        private readonly IHashService hashService;

        public DataBaseContentDisplaying(IOrderService orderService, IHashService hashService, UserProfile userProfile)
        {
            InitializeComponent();

            this.hashService = hashService;

            if (orderService.GetOrders(userProfile) != null)
            {
                ordersGrid.ItemsSource = orderService.GetOrders(userProfile);
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.OrderNotFoundMessage);
                messageBox.ShowDialog();
            }
        }

        private void GetOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (ordersGrid.SelectedItems.Count == 1)
            {
                try
                {
                    Order order = ordersGrid.SelectedItem as Order;

                    if (order != null)
                    {
                        order.FileData = AesCipher.Decrypt(order.FileData, hashService.GetHash());
                        Directory.CreateDirectory(Constant.RootToSaveRetrievedFromDb);
                        using FileStream fs = new FileStream($"{Constant.RootToSaveRetrievedFromDb}" + order.FileName + $"{Constant.WordOfficeExtension}", FileMode.OpenOrCreate);
                        fs.Write(order.FileData, 0, order.FileData.Length);

                        CustomMessageBox messageBox = new CustomMessageBox(Constant.OrderSavedToPcMessage);
                        messageBox.ShowDialog();
                    }
                    else
                    {
                        CustomMessageBox messageBox = new CustomMessageBox(Constant.OrderNotFoundMessage);
                        messageBox.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox messageBox = new CustomMessageBox(ex.Message);
                    messageBox.ShowDialog();
                }
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.ChooseOnlyOneFileForSaveMessage);
                messageBox.ShowDialog();
            }
        }
    }
}