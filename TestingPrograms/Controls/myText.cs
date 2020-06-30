using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace TestingPrograms.Controls
{
    public class myText : TextEdit
    {
        [ToolboxItem(true)]
        public myText()
        {
            Properties.AppearanceFocused.BackColor = Color.LightSteelBlue;
            Properties.AppearanceFocused.ForeColor = Color.Black;
            Properties.Appearance.ForeColor = Color.DimGray;

            Properties.MaxLength = 50;

        }
        public override bool EnterMoveNextControl { get; set; } = true;

    }
}
