﻿using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.EntityFrameworkCore;
using ServiceAccounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ServiceAccounting;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        //using (ApplicationContext db = new ApplicationContext())
        //{
        //    //db.Database.ExecuteSqlRaw(@"CREATE VIEW CustomersTotalSumView AS 
        //    //                                SELECT Customers.Name, Customers.Age, COALESCE(SUM(Products.Price*Purchases.Count),0)
        //    //                                FROM Customers LEFT JOIN Purchases ON Customers.Id=Purchases.CustomerId
        //    //                                Left JOIN Products ON Purchases.ProductId=Products.Id
        //    //                                GROUP BY Customers.Name, Customers.Age");
        //    db.Database.ExecuteSqlRaw(@"CREATE VIEW CustomersTotalSumView AS 
        //                                    SELECT Customers.Name, Products.Name, Purchases.Date, Purchases.Count, Products.Price
        //                                    FROM Customers JOIN Purchases ON Customers.Id=Purchases.CustomerId
        //                                    JOIN Products ON Purchases.ProductId=Products.Id");
        //    db.SaveChanges();
        //}
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}