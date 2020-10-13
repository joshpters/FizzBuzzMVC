# FizzBuzz Challenge Minisite in MVC

This is a minisite that based on my original FizzBuzz challenge minisite, this time build using .NET Core and MVC.

![Screenshot](FizzBuzzMVC/screenshot.png)

This project was created using .NET Core, C#, Bootstrap, HTML5, CSS3, and JavaScript.

## What is the "FizzBuzz" challenge?

"FizzBuzz" is a well known challenge about detecting multiples. Multiples of 3 are labeled a "Fizz", multiples of 5 a "Buzz", and the multiples of both a "FizzBuzz"! In this minisite you have the option of selecting value 1 and value 2.

Since its conception the Fizzbuzz challenge has been used by Facebook and Microsoft as interview tools and has also been taught at Stanford, Berkley, Caltech and countless other universities.

## Installation

This site is currently not live yet.

However, to download and run locally, clone this repository and open index.html.

``` sourceCode
git clone https://github.com/joshpters/FizzBuzzMVC
```

## Core Function

This is a basic form of the function that detects Fizz, Buzz, and FizzBuzz and returns a long string of output.

Currently all data is sent by an Http Post request to the server and processed in C#, then the page is regenerated with the output.

```c#
[HttpPost]
public IActionResult Solve(string input1, string input2)
{
	var fizzNum = Convert.ToInt32(input1);
	var buzzNum = Convert.ToInt32(input2);

	var output = new StringBuilder();

	if (fizzNum == 0 || buzzNum == 0)
	{
		return View();
	}

	for (var index = 1; index <= 100; index++)
	{
		if (index % fizzNum == 0 && index % buzzNum == 0)
		{
			output.AppendLine("FizzBuzz");
		}
		else if (index % fizzNum == 0)
		{
			output.AppendLine("Fizz");
		}
		else if (index % buzzNum == 0)
		{
			output.AppendLine("Buzz");
		}
		else
		{
			output.AppendLine(index.ToString());
		}
	}

	ViewData["Output"] = output;

	return View();
}
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
 
