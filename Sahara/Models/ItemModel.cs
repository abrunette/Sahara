﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

/*
 * Local Item Model for Database references
 * Contains item information variables and images
 * Fixed number of main display images and a secondary list
 */

namespace Sahara
{
    public class ItemModel
    {
        public int ItemId { get; set; }
        public string ItemTitle { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public ImageSource ItemImage1 { get; set; }
        public ImageSource ItemImage2 { get; set; }
        public ImageSource ItemImage3 { get; set; }
        public ImageSource ItemImage4 { get; set; }
        public ImageSource ItemImage5 { get; set; }
        public ImageSource ItemImage6 { get; set; }
        public List<ImageSource> ItemImagesList { get; set; }
    }
}