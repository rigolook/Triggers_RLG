using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triggers_RLG
{
    public class ChangeColor : TriggerAction<Button>
    {
        protected override async void  Invoke(Button btn)
        {
            await Task.Delay(500);
            btn.BackgroundColor = Color.DarkOrange;
            btn.Text = "Aqui vamos!!!";
            await Task.Delay(500);
            btn.BackgroundColor = Color.MediumPurple;
            btn.Text = "DALEEEE!!!";
        }
    }

}
