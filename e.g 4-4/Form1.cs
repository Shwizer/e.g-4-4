#nullable disable
using System;
using System.Windows.Forms;

namespace e.g_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý Đặt món";

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMenu.Items.Add(new FoodItem("Hamburger", 50000));
            lstMenu.Items.Add(new FoodItem("Pizza", 120000));
            lstMenu.Items.Add(new FoodItem("Gà Rán", 35000));
            lstMenu.Items.Add(new FoodItem("Pepsi", 15000));

            UpdateTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một món từ thực đơn bên trái!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FoodItem selectedFood = (FoodItem)lstMenu.SelectedItem;

            lstSelected.Items.Add(selectedFood);

            UpdateTotal();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa trong danh sách đã chọn!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lstSelected.Items.Remove(lstSelected.SelectedItem);

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (var item in lstSelected.Items)
            {
                FoodItem food = (FoodItem)item;
                total += food.Price;
            }

            lblTotal.Text = $"Tổng tiền: {total:N0} VNĐ";
        }
    }

    public class FoodItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public FoodItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:N0}đ";
        }
    }
}