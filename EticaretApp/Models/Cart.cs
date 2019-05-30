﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.Web.Mvc;
using EticaretApp.Entity;

namespace EticaretApp.Models
{
    public class Cart
    {
        private List<CartLine> _cardLines=new List<CartLine>();

        public List<CartLine> CartLines
        {

            get { return _cardLines; }

        }

        public void AddProduct(Product product, int quantity)
        {

            var line = _cardLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();

            if (line == null)
            {
                _cardLines.Add(new CartLine(){Product = product , Quantity = quantity});


            }
            else
            {
                line.Quantity += quantity;
            }

            System.Web.HttpContext.Current.Session["Cart"] = this;

        }

        public void DeleteProduct(Product product)
        {
            _cardLines.RemoveAll(p => p.Product.Id == product.Id);
            System.Web.HttpContext.Current.Session["Cart"] = this;
        }

        public double Total()
        {
            return _cardLines.Sum(i=>i.Product.Price*i.Quantity);

        }

        public void Clear()
        {
            _cardLines.Clear();
        }

    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }


    }
}