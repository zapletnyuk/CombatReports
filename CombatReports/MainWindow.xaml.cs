﻿using CombatReports.Business.Services.Interfaces;
using CombatReports.Data.Models;
using CombatReports.Helpers;
using CombatReports.DialogWindows;
using CombatReports.TableOrders.TypeB3;
using CombatReports.TableOrders.TypeB4;
using CombatReports.TextOrders.TypeB3;
using CombatReports.TextOrders.TypeB4;
using CombatReports.TextOrders.TypeB8;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Constant = CombatReports.Constants.Constants;

namespace CombatReports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IOrderService orderService;
        private readonly IHashService hashService;

        public MainWindow(IOrderService orderService, IHashService hashService)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.hashService = hashService;
        }

        private void TextDocumentsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TextDocumentsComboBox.SelectedIndex)
            {
                case 0:
                    Order3_10 form3_10 = new Order3_10(orderService);
                    form3_10.ShowDialog();
                    return;
                case 1:
                    Order3_24 form3_24 = new Order3_24(orderService);
                    form3_24.ShowDialog();
                    return;
                case 2:
                    Order4_6 form4_6 = new Order4_6(orderService);
                    form4_6.ShowDialog();
                    break;
                case 3:
                    Order8_1 form8_1 = new Order8_1(orderService);
                    form8_1.ShowDialog();
                    break;
                case 4:
                    Order8_2 form8_2 = new Order8_2(orderService);
                    form8_2.ShowDialog();
                    break;
            }
        }

        private void TableDocumentsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TableDocumentsComboBox.SelectedIndex)
            {
                case 0:
                    Order3_2 form3_2 = new Order3_2(orderService);
                    form3_2.ShowDialog();
                    break;
                case 1:
                    Order3_3 form3_3 = new Order3_3(orderService);
                    form3_3.ShowDialog();
                    break;
                case 2:
                    Order3_4 form3_4 = new Order3_4(orderService);
                    form3_4.ShowDialog();
                    break;
                case 3:
                    Order4_1 form4_1 = new Order4_1(orderService);
                    form4_1.ShowDialog();
                    break;
                case 4:
                    Order4_2 form4_2 = new Order4_2(orderService);
                    form4_2.ShowDialog();
                    break;
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nameOfFile = SearchReportTextBox.Text;
                Order order = orderService.GetOrders().FirstOrDefault(o => o.FileName == nameOfFile);

                if (order != null)
                {
                    order.FileData = Encryption.Decrypt(order.FileData, hashService.GetHash());
                    Directory.CreateDirectory(Constant.RootToSaveRetrievedFromDb);
                    using FileStream fs = new FileStream($"{Constant.RootToSaveRetrievedFromDb}" + order.FileName + ".docx", FileMode.OpenOrCreate);
                    fs.Write(order.FileData, 0, order.FileData.Length);

                    CustomMessageBox messageBox = new CustomMessageBox(Constant.OrderSavedMessage);
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

        private void Db_SearchButton_Click(object sender, RoutedEventArgs e)
        {
            DataBaseContentDisplaying dbContent = new DataBaseContentDisplaying(orderService, hashService);
            dbContent.ShowDialog();
        }
    }
}