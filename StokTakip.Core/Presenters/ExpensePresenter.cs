using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Core.Views;

namespace StokTakip.Core.Presenters
{
    public class ExpensePresenter : DataPresenterBase<IExpenseView>
    {
        public ExpensePresenter(IExpenseView view)
            : base(view)
        {

        }

        public override void Initialize()
        {
            try
            {
                this.view.CategoryList = this.repositoryContainer.Expense.GetCategories();
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);
                
                this.view.ShowMessage("Gider kategorileri alınamadı", "RefreshExpenseCategories", MessageType.Error);
            }

            RefreshView();

            base.Initialize();
        }

        public void RefreshView()
        {
            RefreshExpenses(true);

            this.view.ShowMessage("Gdier listesi yenilendi", "RefreshExpenses", MessageType.Information);
        }

        protected void RefreshExpenses(bool showError)
        {
            try
            {
                var list = this.repositoryContainer.Expense.GetList(view.SelectedCategory, view.StartDate, view.EndDate).OrderByDescending(e => e.ExpenseDate).ToList();
                this.view.ExpenseList = list;
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);

                if (showError)
                    this.view.ShowMessage("Giderler alınamadı", "RefreshExpenses", MessageType.Error);
            }
        }

        public void DeleteExpense()
        {
            try
            {
                if (this.view.SelectedExpense != null)
                {
                    this.repositoryContainer.Expense.Delete(this.view.SelectedExpense);
                }
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);
                this.view.ShowMessage("Gider silinemedi", "DeleteExpense", MessageType.Error);
            }
        }
    }
}
