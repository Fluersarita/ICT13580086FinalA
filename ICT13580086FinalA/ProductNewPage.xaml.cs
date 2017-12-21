using System;
using System.Collections.Generic;
using ICT13580086FinalA.Models;
using Xamarin.Forms;

namespace ICT13580086FinalA
{
    public partial class ProductNewPage : ContentPage
    {
		Product product;

        public ProductNewPage(Product product=null)
        {
         
            InitializeComponent();
            this.product = product;

            titleLabel.Text = product == null ? "เพิ่มประวัติใหม่" : "แก้ไขข้อมูลบุคคล";

            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;

            sexPicker.Items.Add("หญิง");
            sexPicker.Items.Add("ชาย");

            statuslovePicker.Items.Add("แต่งงาน");
            statuslovePicker.Items.Add("โสด");
            statuslovePicker.Items.Add("อย่าร้าง");

        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");

            if (isOk)
            {
                if (product == null)
                {
                    product = new Product();
                    product.Name = nameEntry.Text;
                    product.LastName = surnameEntry.Text;
                    product.Age = int.Parse(ageEntry.Text);
                    product.Sex = sexPicker.SelectedItem.ToString();
                    product.Department = departEntry.Text;
                    product.Phone = phoneEntry.Text;
                    product.Email = emailEntry.Text;
                    product.Address = addressEditor.Text;
                    product.Status = statuslovePicker.SelectedItem.ToString();
                    product.Baby = babyEntry.Text;
                    product.Saraly = decimal.Parse(salaryEntry.Text);
                    var id = App.DbHelper.AddProduct(product);
                    await DisplayAlert("บันทึกสำเรจ", "รหัสของท่านคือ " + id, "ตกลง");
                }
                await Navigation.PopModalAsync();
            }
        }

        void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
