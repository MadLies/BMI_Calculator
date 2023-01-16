using Microsoft.Maui.Animations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMI.MVVM.ViewModels
{
    public class BMIViewModel

    {
        public Models.BMI BMI { get; set; }
        public ICommand ReduceHCommand { get; set; }
        public ICommand IncreaseHCommand { get; set; }
        public ICommand ReduceWCommand { get; set; }
        public ICommand IncreaseWCommand { get; set; }
        public BMIViewModel()
        {


            BMI = new Models.BMI();
            BMI.Height = 0;
            BMI.Weight = 0;
            ReduceHCommand = new Command(() =>
            {
                BMI.Height--;
            });
            IncreaseHCommand = new Command(() =>
            {
                BMI.Height++;
            });
            ReduceWCommand = new Command(() =>
            {
                BMI.Weight--;
            });
            IncreaseWCommand = new Command(() =>
            {
                BMI.Weight++;
            });


        }

    

    }
}
