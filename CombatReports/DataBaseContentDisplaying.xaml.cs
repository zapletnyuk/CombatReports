using CombatReports.BLL.Services.Interfaces;
using System.Windows;

namespace CombatReports
{
    /// <summary>
    /// Interaction logic for DataBaseContentDisplaying.xaml
    /// </summary>
    public partial class DataBaseContentDisplaying : Window
    {
        private readonly IOrderService orderService;
        public DataBaseContentDisplaying(IOrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
            ordersGrid.ItemsSource = orderService.GetOrders();
        }
    }
}
