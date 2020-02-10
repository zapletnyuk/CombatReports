using CombatReports.BLL.Services.Interfaces;
using CombatReports.DAL.Models;
using CombatReports.Helpers;
using CombatReports.ManagingWindows;
using System;
using System.IO;
using System.Windows;
using Constant = CombatReports.Constants.Constants;

namespace CombatReports
{
    /// <summary>
    /// Interaction logic for DataBaseContentDisplaying.xaml
    /// </summary>
    public partial class DataBaseContentDisplaying : Window
    {
        private readonly IOrderService orderService;
        private readonly IHashService hashService;
        public DataBaseContentDisplaying(IOrderService orderService, IHashService hashService)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.hashService = hashService;
            if (orderService.GetOrders() != null)
            {
                ordersGrid.ItemsSource = orderService.GetOrders();
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox("У базі даних немає попередньо згенерованих бойових донесень.");
                messageBox.ShowDialog();
            }
        }

        private void getOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (ordersGrid.SelectedItems.Count == 1)
            {
                try
                {
                    Orders order = ordersGrid.SelectedItem as Orders;

                    if (order != null)
                    {
                        order.FileData = Encryption.Decrypt(order.FileData, hashService.GetHash());
                        Directory.CreateDirectory(Constant.RootToSaveRetrievedFromDb);
                        using FileStream fs = new FileStream($"{Constant.RootToSaveRetrievedFromDb}" + order.FileName + ".docx", FileMode.OpenOrCreate);
                        fs.Write(order.FileData, 0, order.FileData.Length);

                        CustomMessageBox messageBox = new CustomMessageBox($"Військове бойове донесення збережено.");
                        messageBox.ShowDialog();
                    }
                    else
                    {
                        CustomMessageBox messageBox = new CustomMessageBox("Військове бойове донесення не знайдено.");
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
                CustomMessageBox messageBox = new CustomMessageBox("Виберіть лише один файл для збереження!");
                messageBox.ShowDialog();
            }
        }
    }
}
