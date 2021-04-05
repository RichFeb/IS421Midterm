using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class MenuItem
    {
        public virtual string Text { get; set; }
        public virtual int? SubMenuId { get; set; }

        public virtual Action Action { get; set; }

        public static MenuItem CreateWithAction(string title, Action action)
        {
            return new MenuItem()
            {
                Text = title,
                Action = action
            };
        }

        public static MenuItem CreateWithSubmenu(string title, int subMenuId)
        {
            return new MenuItem()
            {
                Text = title,
                SubMenuId = subMenuId
            };
        }
    }
}