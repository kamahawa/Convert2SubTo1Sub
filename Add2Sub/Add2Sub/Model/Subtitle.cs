using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2Sub.Model
{
    public class Subtitle
    {
        private int order;
        private TimeSpan startShow;
        private TimeSpan endShow;
        private string content;

        public Subtitle(int order, TimeSpan startShow, TimeSpan endShow, string content)
        {
            this.order = order;
            this.startShow = startShow;
            this.endShow = endShow;
            this.content = content;
        }

        public TimeSpan StartShow
        {
            get
            {
                return startShow;
            }
            set
            {
                startShow = value;
            }
        }

        public int Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
            }
        }

        public TimeSpan EndShow
        {
            get
            {
                return endShow;
            }
            set
            {
                endShow = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
    }
}
