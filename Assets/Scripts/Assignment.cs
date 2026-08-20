using OpenCover.Framework.Model;
using System;
using Unity.VisualScripting;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        As01_CheckNumberSign();
        As02_GetDayName();
        As03_ValidatePassword();
        As04_GetGrade();
        As05_IsLeapYear();
        As06_Calculate();
        As07_GetSeason();
        As08_PurchasingSystemExample();
        As09_RockPaperScissorsExample();
        As10_CalculateWeaponDamage();
        As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        if (as01Number == 0) // ถ้าเลข -> 0 จะตอบได้คำตอบ Zero 
        {
            Debug.Log("Zero");
        }
        if (as01Number < 0) // ถ้าเลขน้อยกว่า 0 -> Negative
        {
            Debug.Log("Negative");
        }
        if (as01Number > 0) // ถ้าเลขน้อยกว่า 0 -> Positive
        {
            Debug.Log("Positive");
        }

    }

    public int as02Day;
    public void As02_GetDayName()
    {
        if (as02Day == 1)
        {
            Debug.Log("Monday");
        }

        else if (as02Day == 2)
        {
            Debug.Log("Tuesday");
        }

        else if (as02Day == 3)
        {
            Debug.Log("Wednesday");
        }

        else if (as02Day == 4)
        {
            Debug.Log("Thursday");
        }

        else if (as02Day == 5)
        {
            Debug.Log("Friday");
        }

        else if (as02Day == 6)
        {
            Debug.Log("Saturday");
        }

        else if (as02Day == 7)
        {
            Debug.Log("Sunday");
        }

        else //ถ้าเขียนเลขหลังจาก 7 ขึ้นไปจะได้คำตอบเป็น Invalid day เสมอ
        {
            Debug.Log("Invalid day");
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword) //กรณีที่ as03InputPassword เหมือนกัน as03CorrectPassword
        {
            Debug.Log("True"); 
        }
        else  //กรณีที่ as03InputPassword แตกต่างกัน as03CorrectPassword
        {
            Debug.Log("False"); 
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        if (as04Score <= 80) //กรณีที่เลขมากกว่าหรือเท่ากับ 80 ขึ้นไป -> A
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70) //กรณีที่เลขเท่ากับหรือน้อยกว่า 70 -> B
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60) //กรณีที่เลขเท่ากับหรือน้อยกว่า 60 -> C
        {
            Debug.Log("C"); 
        }
        else if (as04Score >= 50) //กรณีที่เลขเท่ากับหรือน้อยกว่า 50 -> D
        {
            Debug.Log("D");
        }
        else //กรณีที่เลขน้อยกว่า 49 ลงไปจะได้คำตอบเป็น F เสมอ
        {
            Debug.Log("F");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        if (as05Year %400 == 0) //ถ้า%400ลงตัว -> True
        {
            Debug.Log("True");
        }
        else if (as05Year %4 == 0) //ถ้า%4ลงตัว -> True
        {
            Debug.Log("True");
        }
        else if (as05Year %100 == 0) //ถ้า%100ลงตัว -> False
        {
            Debug.Log("False");
        }
        else //กรณีที่หารด้วยเลขอื่นนอกเหนือจาก 400 & 100 จะได้คำตอบเป็น False เสมอ
        {
            Debug.Log("False");
        }

    }

     public double as06Num1;
     public char as06Op;
     public double as06Num2;
     public void As06_Calculate()
     {
        double as06Op = 0;   //เปลี่ยนจาก Char -> double เพื่อเปลี่ยนเป็นตัวเลข

        switch (as06Op)  
        {
        case '+': as06Op = as06Num1 + as06Num2; break;

        case '-': as06Op = as06Num1 - as06Num2; break;

            case '/':    
                if (as06Num2 == 0) //กรณีที่ใช้ 0 ในการหาร
                {
                    Debug.Log("Error: Cannot divide by zero");
                }
               else
               {
                    as06Op = as06Num1 / as06Num2;
               }
               break;

        case '*':
                if (as06Num2 == 0) //กรณีที่ใช้ 0 ในการคูณ
                {
                    Debug.Log("Error: Cannot divide by zero");
                }
                else
                {
                    as06Op = as06Num1 * as06Num2;
                }
                break;

            default: //กรณที่ใช้สัญลักษณ์อื่นนอกเหนือจากที่กำหนดไว้
           Debug.Log("Invalid because it only accepts +, -, *, or /"); 
           return;
        }
     }

    public int as07Month;
    public void As07_GetSeason()
    {
        if(as07Month >= 1 && as07Month <= 12) //กำหนดค่าตัวแปรที่ใช้ได้
        {
            if (as07Month == 1 || as07Month == 2 || as07Month == 12)
            {
                Debug.Log("Winter");
            }
            else if (as07Month >= 3 || as07Month >= 5)
            {
                Debug.Log("Spring");
            }
            else if (as07Month >= 6 || as07Month >= 8)
            {
                Debug.Log("Summer");
            }
            else if (as07Month >= 9 || as07Month >= 11)
            {
                Debug.Log("Fall");
            }
            else //กรณีที่เขียนตัวเลขอื่นนอกเหนือจากที่กำหนดไว้
            {
                Debug.Log("Invalid because there are only 1-12 months");
            }
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0)
        {
            Debug.Log("สินค้าหมดเเล้ว");
        }
        else
        {
            if (as08Payment >= as08Price) // กรณีที่มีสินค้าใน (as08Quantity > 0)
            {
                Debug.Log("ได้รับสินค้าเเล้ว");

                    if(as08Payment > as08Price)  // กรณีหากมีเงินทอน
                {
                    Debug.Log($"ได้รับเงินทอน {as08Payment - as08Price} บาท");
                }
            }
            else
            {
                Debug.Log("เงินไม่เพียงพอ");   // กรณีที่ไม่มีเงินพอ 
            }
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {

        if (as09UserChoice < 0 || as09UserChoice > 2) //กำหนดค่าตัวแปรที่ใช้ได้
        {
            Debug.Log("ใช้ตัวเลขได้เเค่ตามที่กำหนดไว้ -> 0=Rock 1=Paper 2=Scissors");
        }
        else if (as09UserChoice == as09ComputerChoice) //ถ้าเลขเหมือนกันจะเสมอตลอด
        {
            Debug.Log("เสมอ");
        }
        else if (as09UserChoice == 0 && as09ComputerChoice == 2) 
        {
            Debug.Log("คุณชนะ!");
        }
        else if (as09UserChoice == 1 && as09ComputerChoice == 0)
        {
            Debug.Log("คุณชนะ!");
        }
        else if (as09UserChoice == 2 && as09ComputerChoice == 1)
        {
            Debug.Log("คุณชนะ!");
        }
        else //กรณีที่ใช้ค่าอื่นนอกเหนือจากที่กำหนดไว้
        {
            Debug.Log("คุณแพ้แล้ว!");
        }

    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {

        double multiplier = 1.0;
        switch (as10WeaponType?.ToLower())
        {
          case "sword": multiplier = 1.3; break;

          case "axe": multiplier = 1.4; break;

          case "bow": multiplier = 1.2; break;

          case "staff": multiplier = 1.5; break;

          case "dagger": multiplier = 1.1; break;

          case "unknown / other": multiplier = 1.0; break;
        }
        int totalDamage = (int)(as10BaseDamage * multiplier); //เอาชื่ออาวุธมาคูณกับ Multiplier
        Debug.Log(totalDamage.ToString()); //สรุปผลที่ได้มา

    }
    
    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {

        if (as11Score < 0 || as11CompletionTime < 0)
        {
            Debug.Log("Invalid score or time");
            return;
        }

        string rank;  //กำหนดค่าให้ rank เป็นตัวอักษร
        int baseCoins; //กำหนดค่าให้ baseCoins เป็นตัวเลข

        if (as11Score >= 8000)
        {
            rank = "Gold"; baseCoins = 100;
        }

        else if (as11Score >= 6000)
        {
            rank = "Silver"; baseCoins = 75;
        }
        else if (as11Score >= 4000)
        {
            rank = "Bronze"; baseCoins = 50;
        }
        else //กรณีที่เลขน้อยกว่า 3999 จะได้ Participation เสมอ
        {
            rank = "Participation"; baseCoins = 25;
        }

        int timeBonus = 0;
        if (as11CompletionTime <= 30)
        {
            timeBonus = 25;
        }
        else if (as11CompletionTime <= 60)
        {
            timeBonus = 10;
        }
        int totalCoins = baseCoins + timeBonus;     //นำค่าของทั้ง 2 ตัวแปรมาคำนวนรวมกัน
        Debug.Log($"{rank} Rank - {totalCoins} Coins earned!");  //สรุปผลทั้งหมด
    }
}
