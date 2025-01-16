﻿namespace ExceptionHandling.Demo.StatusCodes
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, '{Name}', Description: '{Description}'.";
        }
    }
}
