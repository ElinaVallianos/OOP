using System;
using Lesson17;
namespace Lesson17a
{
    public class Wagon2
    {
        private Lesson17.WagonType type;
        private Wagon2? next;
        private Wagon2? prev;

        public WagonType Type { get => type; }
        public Wagon2? Prev
        {
            get => prev;
            set
            {
                prev = value;
                if (value != null && value.Next != this)
                {
                    value.Next = this;
                }

                if (value != null)
                {
                    value.Next = this;
                }
                value.Next = this;
            }
        }
        public Wagon2? Next
        {
            get => next;
            set
            {
                next = value;
                if(value != null)
                {
                    value.Prev = this;
                }
                value.Prev = this;

            }
        }

        public Wagon2(WagonType type)
        {
            this.type = type;
        }
    }
}

