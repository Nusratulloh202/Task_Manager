using Task_Manager.HelperClass;

PasswordClass passwordClass = new PasswordClass();
passwordClass.ValidatePassword();

Console.WriteLine("Bajariladigan vazifa raqamini tanlang:" +
    "\n1. Foydalanuvchi ma'lumotlar ustida amallar." +
    "\n2. Factorialni hisoblash." +
    "\n3. Sonlar ustida (+,-,*,/) amallari." +
    "\n4. To'rburchak yuzasi va perimetrini hisoblash." +
    "\n5. Parol ustida amallar.");
int selectionNumber = int.Parse(Console.ReadLine());
Console.Clear();

switch (selectionNumber)
{
    case 1:
        {
            Console.WriteLine("Tanlangan vazifa, foydalanuvchi ma'lumotlar ustida amallar.");
            UserInformation userInformation = new UserInformation();
            userInformation.AddUser();
            break;
        }
    case 2:
        {
            Console.WriteLine("Tanlangan vazifa, Factorial hisoblash.");
            Factorial factorial = new Factorial();
            factorial.InputFactor();
            break;
        }
    case 3:
        {
            Console.WriteLine("Tanlangan vazifa, Sonlar ustida (+,-,*,/) amallari.");
            MathOperations mathOperations = new MathOperations();
            mathOperations.MathOperation();
            break;
        }
    case 4:
        {
            Console.WriteLine("Tanlangan vazifa, To'rburchak yuzasi va perimetrini hisoblash.");
            GeometricShapes geometricShapes = new GeometricShapes();
            geometricShapes.GeometricShapVoid();
            break;
        }

}
