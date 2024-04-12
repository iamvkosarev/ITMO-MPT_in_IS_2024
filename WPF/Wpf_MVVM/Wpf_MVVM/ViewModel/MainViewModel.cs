using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wpf_MVVM.Model;

namespace Wpf_MVVM.ViewModel
{
    class MainViewModel
    {
        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        public MainViewModel()
        {
            People = new PeopleModel{
                FirstName = "First name",
                LastName = "Last name" 
            };
            ClickCommand = new Command(arg => ClickMethod());
        }
        #endregion
        #region Properties
        /// <summary>
        /// Get or set people.
        /// </summary>
        public PeopleModel People { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Click method.
        /// </summary>
        private void ClickMethod()
        {
            if (MessageBox.Show("Clear data?", $"Data: {People.FirstName}, {People.LastName}", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                People.FirstName = "";
                People.LastName = "";
            }
        }
        #endregion

        #region Commands
        /// <summary>
        /// Get or set ClickCommand.
        /// </summary>
        public ICommand ClickCommand { get; set; }
        #endregion

    }
}
