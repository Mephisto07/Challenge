// Highest and Lowest

// In this little assignment you are given a string of 
// space separated numbers, and have to return the highest 
// and lowest number.

function highAndLow(numbers){
  // numbers = numbers.split(" ");
  // var low = parseInt(numbers[0]), high = parseInt(numbers[0]);
  // for (var i = 0; i < numbers.length; i++){
  //   var num = parseInt(numbers[i]);
  //   low = low <= num ? low : num;
  //   high = high >= num ? high : num;
  // }
  // return high + " " + low;
  
  numbers = numbers.split(' ').map(Number);
  return Math.max.apply(0, numbers) + ' ' + Math.min.apply(0, numbers);
}

highAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6");
