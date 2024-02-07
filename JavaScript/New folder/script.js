// alert("aa");

// x=5;
// y=2;
// z=x+y;
// alert(z);

// function varScoping() {
//   var x = 1;

//   if (true) {
//     var x = 2;
//     console.log(x); // will print 2
//   }

//   console.log(x); // will print 2
// }

// function letScoping() {
//   let x = 1;

//   if (true) {
//     let x = 2;
//     console.log(x); // will print 2
//   }

//   console.log(x); // will print 1
// }

// varScoping();
// letScoping();

let sum = function(a, b) {
  return a + b;
};
console.log(sum);