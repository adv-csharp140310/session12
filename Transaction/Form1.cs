using App12;
using AppTransaction.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace AppTransaction;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonFail_Click(object sender, EventArgs e)
    {
        AddProduct();
        AddCategory();
    }

    private void AddCategory()
    {
        var ctx = new AppDbContext();
        var ctategory = new Category { Name = "Monitor 1234567890", IsActive = true, Description = "Test" };
        ctx.Categories.Add(ctategory);
        ctx.SaveChanges();
    }

    private void AddProduct()
    {
        var ctx = new AppDbContext();
        var product = new Product { Name = "Monitor LG", Price = 100, Description = "Test" };
        ctx.Products.Add(product);
        ctx.SaveChanges();
    }

    private void buttonEF_Click(object sender, EventArgs e)
    {
        //DAL
        var ctx = new AppDbContext(); //new transaction

        //BLL
        var product = new Product { Name = "Monitor LG", Price = 100, Description = "Test" };
        var ctategory = new Category { Name = "Monitor 1234567890", IsActive = true, Description = "Test" };

        ctx.Products.Add(product);
        ctx.Categories.Add(ctategory);

        ctx.SaveChanges(); // commit transaction
    }

    private void buttonScope_Click(object sender, EventArgs e)
    {
        using var scope = new TransactionScope();
        AddProduct();
        AddCategory();
        scope.Complete(); // commit
    }

    private void buttonRepository_Click(object sender, EventArgs e)
    {
        var repo = new Repository();
        var product = new Product { Name = "Monitor LG", Price = 100, Description = "Test" };
        var ctategory = new Category { Name = "Monitor 1234567890", IsActive = true, Description = "Test" };
        repo.Create(product);
        repo.Create(ctategory);
        repo.SaveChanges();
    }
}
