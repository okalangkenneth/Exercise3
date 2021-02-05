using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
    abstract class UserError
    {

        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            string message="You tried to use a numerical input in a text only field.This fired an error";
            return message; 
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            string message = "You tried to use a text input in a numeric only field. This fired an error!";
            return message;
        }   
    }
    class DivideByZeroException : UserError
    {
        public override string UEMessage()
        {
            string message= "You tried to to divide by zero";
            return message;
        }
    }
    class ArgumentException : UserError
    {
        public override string UEMessage()
        {
            string message="You passed Non-null argument to method";
            return message;
        }
    }
    class FormatException : UserError
    {
        public override string UEMessage()
        {
            string message ="The value you entered is not in appropriate format";
            return message;
        }
    }
}


