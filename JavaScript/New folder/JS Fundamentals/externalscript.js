
"use strict";

// alert("External Script");

// let message;
// message = 'hello';

// alert(message);

// const DATE='08-02-2024';
// DATE = '13-04-2024';

// alert(DATE);


// Task

// let admin,name;
// name="John";
// admin=name;

// alert(admin);

// -------------------------------------------------

// DataTypes
// let number =123, str="abcd", age;
// alert("number= "+number+" str= "+str);
// let isGreater=number>1000;
// alert(isGreater);
// alert(age);

// Task

// let name= "Abhi";
// alert(`hello ${1}`); //hello 1
// alert(`hello ${"name"}`); //hello name
// alert(`hello ${name}`); //hello Abhi

// ---------------------------------------------------

// Interaction: alert, prompt, confirm

// alert("alert");

// let age=prompt("how old are you",100);
// alert(`you are ${age} years old`);

// let isboss=confirm("Are you the boss?");
// alert(isboss);

// alert
// shows a message.
// prompt
// shows a message asking the user to input text. It returns the text or, if Cancel button or Esc is clicked, null.
// confirm
// shows a message and waits for the user to press “OK” or “Cancel”. It returns true for OK and false for Cancel/Esc.

// Task:Create a web-page that asks for a name and outputs it.

// let name=prompt("Enter Your Name");
// alert("Your name is : "+name);

// ----------------------------------------------------------

// Type convertions

// let value=true;
// alert(typeof(value));

// value=String(value);
// alert(typeof(value));

// String,Number,Boolean,

// ----------------------------------------------------------

// Operators

// alert(2**2);//4
// let s = "my" + "string";
// alert(s); // mystring

// alert(2+2+'1');//41
// alert('1'+2+2);//122

// let counter=0;
// counter++;
// alert(counter);
// ++counter;
// alert(counter);

// Tasks
// The postfix and prefix forms

// let a=1,b=1;
// let c= ++a;//2
// let d= b++;//1

// alert(`a= ${a}, b=${b}, c=${c}, d=${d} `);

// let a = +prompt("First number?", 1);
// let b = +prompt("Second number?", 2);

// alert(a + b); // 3

// ----------------------------------------------------------

// if

// if("0"){
// 	alert('hello');
// }else{
// 	alert("bye");
// }

// let value = prompt("Number",0);
// if (value>0) 
// {
// 	alert(1);
// }
// else if(value<0)
// {
// 	alert(-1);
// }
// else
// {
// 	alert(0);
// }

// let a=0,b=1
// let value = (a+b<4)?'Below':'Over';
// alert(value);

// -------------------------------------------------
// Nullish coalescing operator '??'

// gives false next value
// 	|| = null,undefined,0,false,NAN,"" this all are gives falsy value.
// 	?? = null,undefined
	
	// var num;
	// var mynum = num || 10;
	// var mynum1 = num ?? 10;

	// alert("munum || = "+mynum);	
	// alert("mynum1 ?? = "+mynum1);	

// -------------------------------------------------

// Loops
// let i = 3;

// while (i) {
//   alert( i-- );
// }

// for (var i = 2; i<=10; i++) 
// {
// 	if (i%2 ==0) {
// 		alert(i);
// 	}	
// }


