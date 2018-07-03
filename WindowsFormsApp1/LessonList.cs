using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English
{
    public partial class LessonList : UserControl
    {

        private static LessonList _instance;

        public static LessonList Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LessonList();
                }
                return _instance;
            }
        }

        private int lessonNumber;

        

        public LessonList()
        {
            InitializeComponent();
        }
    }
}
