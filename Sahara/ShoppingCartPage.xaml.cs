﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sahara
{
    public partial class shoppingCartPage : ContentPage
    {
        public ObservableCollection<Item> ItemList { get; set; }

        public shoppingCartPage()
        {
            InitializeComponent();

            PopulateShoppingCart();
        }

        private void PopulateShoppingCart()
        {
            ItemList = new ObservableCollection<Item>()
            {
                new Item()
                {
                    ItemTitle = "Profile Picture",
                    ItemPrice = 200,
                    ItemImage1 = "profilePic.jpg"

				},

				new Item()
				{
                    ItemTitle = "Shopping cart",
                    ItemPrice = 1000,
                    ItemImage1 = "shoppingCart.jpg"
				},

                new Item()
                {
                    ItemTitle = "item 3",
                    ItemPrice = 50,
                    ItemImage1 = "profilePic.jpg"
                }

            };

            shoppingCartListView.ItemsSource = ItemList;
        }

    }
}