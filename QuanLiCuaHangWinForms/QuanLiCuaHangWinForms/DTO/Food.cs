﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DTO
{
    public class Food
    {
        public Food(DataRow row)
        {
            this.id = Convert.ToInt32(row["ID"]);
            this.foodName = row["FoodName"].ToString();
            this.FoodCate = Convert.ToInt32(row["FoodCategory"]);
            this.price = float.Parse((row["Price"].ToString()));
            this.urlImage = row["urlImage"].ToString();
        }
        public Food(int id, string foodName, int foodCate, float price, string urlImage)
        {
            this.id = id;
            this.foodName = foodName;
            this.FoodCate = foodCate;
            this.price = price;
            this.urlImage = urlImage;
        }
        private int id;
        private string foodName;
        private int foodCate;
        private float price;
        private string urlImage;

        public int Id { get => id; set => id = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int FoodCate { get => foodCate; set => foodCate = value; }
        public float Price { get => price; set => price = value; }
        public string UrlImage { get => urlImage; set => urlImage = value; }
    }
}
