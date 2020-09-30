using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DatarynxPgmTest.Models;

namespace DatarynxPgmTest.ViewModels
{
    public class TaskDetailsViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<TaskDetails> items;
        public ObservableCollection<TaskDetails> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }



        private TaskDetails _taskState;

        public TaskDetails TaskState
        {
            get { return _taskState; }
            set
            {
                _taskState = value;
                OnPropertyChanged("TaskState");
            }
        }


        private bool _buttonVisible;


        public bool ButtonVisible
        {
            get
            {

                if (TaskState.TaskState == "Not Started")
                {
                    return true;
                }
                return false;
            }

        }

        public TaskDetailsViewModel()
        {
            Items = new ObservableCollection<TaskDetails>()
            {
                new TaskDetails{WeekNo="Wk35",WeekDate="08-09",StoreName="34492783/NEW RANDOLPH STORE 0045",StoreAddress="630 3RD ST WEST, RANDOLPH AFB, TX, 78150",CodingType="Item Coding",TaskState="Not Started"},
                new TaskDetails{WeekNo="Wk35",WeekDate="08-09",StoreName="24492783/NEW RANDOLPH STORE 0045",StoreAddress="530 3RD ST WEST, RANDOLPH AFB, TX, 78150",CodingType="Item Coding",TaskState="Not Started"},
                new TaskDetails{WeekNo="Wk36",WeekDate="08-09",StoreName="14492783/NEW RANDOLPH STORE 0045",StoreAddress="430 3RD ST WEST, RANDOLPH AFB, TX, 78150",CodingType="Item Coding",TaskState="In-Progress"},
                new TaskDetails{WeekNo="Wk37",WeekDate="08-09",StoreName="04492783/NEW RANDOLPH STORE 0045",StoreAddress="330 3RD ST WEST, RANDOLPH AFB, TX, 78150",CodingType="Item Coding",TaskState="Un-Defined"},
                new TaskDetails{WeekNo="Wk38",WeekDate="08-09",StoreName="00492783/NEW RANDOLPH STORE 0045",StoreAddress="230 3RD ST WEST, RANDOLPH AFB, TX, 78150",CodingType="Item Coding",TaskState="Not Applicable"},
                new TaskDetails{WeekNo="Wk39",WeekDate="08-09",StoreName="00492783/NEW RANDOLPH STORE 0045",StoreAddress="230 3RD ST WEST, RANDOLPH AFB, TX, 78150",CodingType="Item Coding",TaskState="Not Started"},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
