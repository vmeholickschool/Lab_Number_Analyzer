using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net.Security;
using System.Numerics;

int x;
x = 5;
int y = 10;

int itemCount = 0;
long distance = 500000000;

///float temperature = 96.61F;
double price = 19.99;
///decimal accountBalance = 1500.75M

string camelCase;
string PascalCase;

bool isElgible = true;
string userName;
string franchiseName;

char studentGrade = 'A';
string firstName = "Scott";

string lastName = "7";

int a = 5;
int b = 10;
int sum = a + b;
int difference = a - b;
int product = a * b;
int quotient = a / b;
int modulus = a % 2;
int modForThree = a % 3;// if modForThree = 0, mumber is divisible by 3

int counter = 10;
counter++;
counter--;

a += b; //a = a + b

int lenght = 4;
int width = 3;
int area = lenth * width;
int perimeter = (lenght * 2) + (width * 2);


string userFirstName = "John";
string userLastName = "Doe";
string fullName = userFirstName + " " + userLastName;//concatinate

char firstInitial = userFirstName[0];

int stringLength = lastName.Length;//length of what is in the variable

string replacedName = fullName.Replace("0", "a");
string otherReplacedName = fullName.Replace("John", "Steve");

char letter = 'A';
bool isDigit = Char.IsDigit(letter);//false
bool isLetter = Char.IsLetter(letter); //true
string weirdText = "HeLlio wORLd";
string originalText = "Hello World";
string upperText = originalText.ToUpper();
string lowerText = originalText.ToLower();

bool isEqual = originalText == weirdText;
bool haveProduct = originalText.ToLower() == weirdText.ToLower();

