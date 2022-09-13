﻿using System;
using VendasWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace VendasWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Amount { get; set; }
        public SalesStatus MyProperty { get; set; }
        public Seller Seller { get; set; } //Conexão com a class Seller

        //Construtores
        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus myProperty, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            MyProperty = myProperty;
            Seller = seller;
        }
    }
}
