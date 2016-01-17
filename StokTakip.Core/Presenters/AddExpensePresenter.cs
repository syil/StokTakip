using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Core.Views;

namespace StokTakip.Core.Presenters
{
    public class AddExpensePresenter : DataPresenterBase<IAddExpenseView>
    {
        public AddExpensePresenter(IAddExpenseView view)
            : base(view)
        {

        }

        public override void Initialize()
        {
            this.Refresh();

            base.Initialize();
        }

        public void Refresh()
        {
            try
            {
                var categories = this.repositoryContainer.Expense.GetCategories();
                this.view.CategoryList = categories;
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);
                this.view.ShowMessage("Kategoriler çekilirken sorun oluştu", "RefreshCategories", MessageType.Error);
            }
        }

        public void AddExpense()
        {
            var newExpense = this.view.Expense;

            if (newExpense != null)
            {
                this.view.ShowMessage("Ekleniyor...", "AddExpense", MessageType.Wait);
                try
                {
                    this.repositoryContainer.Expense.AddNew(newExpense);
                    this.view.ShowMessage("Gider eklendi", "AddExpense", MessageType.Success);
                }
                catch (Exception ex)
                {
                    this.logger.Exception(ex);
                    this.view.ShowMessage("Gider eklenirken bir sorun oluştu", "AddExpense", MessageType.Error);
                }
            }
        }

        public void UpdateExpense()
        {
            var expense = this.view.Expense;

            if (expense != null)
            {
                this.view.ShowMessage("Güncelleniyor...", "UpdateExpense", MessageType.Wait);
                try
                {
                    this.repositoryContainer.Expense.Update(expense);
                    this.view.ShowMessage("Gider güncellendi", "UpdateExpense", MessageType.Success);
                }
                catch (Exception ex)
                {
                    this.logger.Exception(ex);
                    this.view.ShowMessage("Gider güncellenirken bir sorun oluştu", "UpdateExpense", MessageType.Error);
                }
            }
        }
    }
}
