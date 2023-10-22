using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace ConditionalDataAnnotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person<Cat> cat = new Person<Cat>();
            cat.Name = null;
            cat.IsValid();
        }
    }

    public class Cat { }
    public class Dog { }

    public class Person<T> : ValidationAttribute where T : class, new()
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ValidationResult Validate()
        {
            if(typeof(T) == typeof(Cat))
            {
                if(Name is null)
                {
                    return new ValidationResult("Cat name is required");
                }
            }
            else if (typeof(T) == typeof(Dog))
            {
                if(Name is not null)
                {
                    return new ValidationResult("Dog name must be null");
                }
            }

            return ValidationResult.Success;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (typeof(T) == typeof(Cat))
            {
                if (Name is null)
                {
                    return new ValidationResult("Cat name is required");
                }
            }
            else if (typeof(T) == typeof(Dog))
            {
                if (Name is not null)
                {
                    return new ValidationResult("Dog name must be null");
                }
            }

            return ValidationResult.Success;
        }
    }
}