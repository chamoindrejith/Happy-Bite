using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Bite
{
    public partial class ShoppingList : Form
    {
        private Favourites fav = new Favourites();
        private MealPlans plans = new MealPlans();
        private Home home = new Home();
        private Recipies recipies = new Recipies();
        public ShoppingList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if(fav == null || fav.IsDisposed)
            {
                fav = new Favourites();
            }
            this.Hide();
            fav.Show();
        }

        private void btnMealPlan_Click(object sender, EventArgs e)
        {
            if(plans == null || plans.IsDisposed)
            {
                plans = new MealPlans();
            }

            this.Hide();
            plans.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(home == null || home.IsDisposed)
            {
                home = new Home();
            }
            this.Hide();
            home.Show();
        }

        private void btnRecipie_Click(object sender, EventArgs e)
        {
            if (recipies == null || recipies.IsDisposed)
            {
                recipies = new Recipies();
            }
            this.Hide();
            recipies.Show();
        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnGenerateList_Click(object sender, EventArgs e)
        {

        }
    }
}
