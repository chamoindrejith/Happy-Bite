using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Bite
{
    public partial class Recipies : Form
    {
        private Favourites fav = new Favourites();
        private MealPlans plans = new MealPlans();
        private Home home = new Home();
        private ShoppingList list = new ShoppingList();
        private ViewRecipie viewrecipie = new ViewRecipie();
        private AddRecipie add = new AddRecipie();
        private EditRecipie edit = new EditRecipie();   
        public Recipies()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            this.Hide();
            fav.Show();
        }

        private void btnMealPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            plans.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }

        private void btnRecipie_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            this.Hide();
            list.Show();
        }

        private void linklblView6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            viewrecipie.Show();
        }

        private void linklblView7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            viewrecipie.Show();
        }

        private void linklblView8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            viewrecipie.Show();
        }

        private void linklblView9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            viewrecipie.Show();
        }

        private void linklblView10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            viewrecipie.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            add.Show();
        }

        private void linklblEdit1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            edit.Show();
        }

        private void linklblEdit2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            edit.Show();
        }

        private void linklblEdit3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            edit.Show();
        }

        private void linklblEdit4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            edit.Show();
        }

        private void linklblEdit5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            edit.Show();
        }
    }
}
