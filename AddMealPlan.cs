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
    public partial class AddMealPlan : Form
    {
        private ShoppingList list = new ShoppingList();
        private MealPlans plans = new MealPlans();
        private Home home = new Home();
        private Favourites favourites = new Favourites();
        private Recipies recipies = new Recipies();
        private ViewRecipie view = new ViewRecipie();
        public AddMealPlan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            plans.Show();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            this.Hide();
            favourites.Show();
        }
        private void btnMealPlan_Click(object sender, EventArgs e)
        {
            this.Show();
            MealPlans plans = new MealPlans();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }

        private void btnRecipie_Click(object sender, EventArgs e)
        {
            this.Hide();
            recipies.Show();
        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            this.Hide();
            list.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
