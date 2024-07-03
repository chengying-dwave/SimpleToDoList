﻿using CommunityToolkit.Mvvm.ComponentModel;
using SimpleToDoList.Models;

namespace SimpleToDoList.ViewModels
{
    /// <summary>
    /// This is a ViewModel which represents a <see cref="Models.ToDoItem"/>
    /// </summary>
    public partial class ToDoItemViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the checked status of each item
        /// </summary>
        [ObservableProperty]
        private bool _isChecked;

        /// <summary>
        /// Gets or sets the content of the to-do item
        /// </summary>
        [ObservableProperty]
        private string? _content;

        /// <summary>
        /// Creates a new blank ToDoItemViewModel
        /// </summary>
        public ToDoItemViewModel()
        {
            // empty
        }

        /// <summary>
        /// Creates a new ToDoItemViewModel for the given <see cref="Models.ToDoItem"/>
        /// </summary>
        /// <param name="item">The item to load</param>
        public ToDoItemViewModel(ToDoItem item)
        {
            // Init the properties with the given values
            IsChecked = item.IsChecked;
            Content = item.Content;
        }
    }
}
