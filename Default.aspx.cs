using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //initialize the basic math class
    BasicMath m = new BasicMath();
    int answer = 0; //declare answer variable
    //the random numbers at class level
    int number1;
    int number2;

    protected void Page_Load(object sender, EventArgs e)
    {
        //this is to provide a problem when the page first loads
        //the !IsPostback guarantees it runs only
        //on the first page load not on button clicks
        if (!IsPostBack)
            GetAddition();
    }
    protected void addition_Click(object sender, EventArgs e)
    {
        //call the get addition method
        GetAddition();
    }

    protected void GetAddition()
    {
        // call the getNumbers method and pass
        //it the min, max, and operator
        GetNumbers(0, 100, "+");
        //get the answer from the class
        answer = m.Addition();
        //store it in a session variable
        Session["answer"] = answer;
    }

    protected void GetNumbers(int min, int max, string oper)
    {
        //get the random numbers and display them in the labels
        //including the operation
        RandomGenerator rg = new RandomGenerator(max, min);
        //assign the random numbers to variables
        number1 = rg.GetNumber();
        number2 = rg.GetNumber();
        //check the operator
        if (oper.Equals("-") || oper.Equals("/"))
        {
            //check to see if the first number
            //is less than the second number
            if (number1 < number2)
            {
                //if it is call NumberSwap()
                NumberSwap();
            }
        }
        //assign the numbers to the labels
        lblNumber1.Text = number1.ToString();
        lblNumber2.Text = number2.ToString();
        lblOperator.Text = oper;
        //assign them to the class
        m.NumberOne = int.Parse(lblNumber1.Text);
        m.NumberTwo = int.Parse(lblNumber2.Text);
        

    }
    protected void btnCheckAnswer_Click(object sender, EventArgs e)
    {

        //if the session exists
        if (Session["answer"] != null)
        {
            if (lblOperator.Text.Equals("/"))
            {
                CheckDivision();
                return;
            }
            //get their answer --should be try parse
            int userAnswer = int.Parse(txtUserAnswer.Text);
            //get the actual answer from the session variable
            answer = (int)Session["answer"];
            //if the anser is correct congrats
            if (userAnswer == answer)
            {
                lblResult.Text = "Great job";
                //assign a cssClass on the fly
                lblResult.CssClass = "correct";

            }
            else //otherwise try again
            {
                lblResult.Text = "Try again";
                txtUserAnswer.Text = "";
                txtUserAnswer.Focus();
                lblResult.CssClass = "mistake";
            }
        }
    }

    protected void btnDivision_Click(object sender, EventArgs e)
    {
        GetNumbers(1, 10, "/");
        answer = m.Division();
        int remainder = m.Remainder();
        Session["answer"] = answer;
        Session["remainder"] = remainder;
    }

    public void NumberSwap()
    {
        int number3=0;
        number3 = number2;
        number2 = number1;
        number1 = number3;
        
    }

    protected void CheckDivision()
    {
        //make sure that both sessions exist
        if (Session["answer"] != null && Session["remainder"] != null)
        {
            //get the values from the session
            answer = (int)Session["answer"];
            int remainder = (int)Session["remainder"];
            //create variables for the user answers
            int userRemainder=0;
            int userAnswer=0;
            //do try parses to handle bad entrys or no entry
            bool goodAnswer = int.TryParse(txtUserAnswer.Text, out userAnswer);
            if (!goodAnswer)
            {
                //if the answer is not valid generate a javascript alert
                Response.Write("<script language='JavaScript'>alert('Please Enter a good Number')</script>");
                return;
            }
            bool goodRemainder = int.TryParse(txtRemainder.Text, out userRemainder);
            if (!goodRemainder)
            {
                userRemainder = 0;
            }
            //check the answer
            if (userAnswer == answer && userRemainder == remainder)
            {
              lblResult.Text = "Great job";
                //assign a cssClass on the fly
                lblResult.CssClass = "correct";

            }
            else //otherwise try again
            {
                lblResult.Text = "Try again";
                txtUserAnswer.Text = "";
                txtUserAnswer.Focus();
                lblResult.CssClass = "mistake";
            }
        }
    }
}