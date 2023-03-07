using System;
namespace HomeWork20
{
    public interface IMovable
    {
        public Vector Direction { get; set; }
        public void Move();
    }
}

