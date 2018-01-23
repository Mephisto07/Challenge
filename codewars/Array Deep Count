//https://www.codewars.com/kata/array-deep-count/train/javascript
function deepCount(a){
  if (a.length === 0) {
    return 0;
  } else {
    var length = 0;
    for (var i = 0; i<a.length; i++){
      if (typeof a[i] !== 'object'){
        ++length;
      }else{
        length += deepCount(a[i]) + 1;
      }
    }
  }
  return length;
}

console.log(deepCount([]), 0, "Expected 0");
console.log(deepCount([1, 2, 3]), 3, "Expected 3");
console.log(deepCount(["x", "y", ["z"]]), 4, "Expected 4");
console.log(deepCount([1, 2, [3, 4, [5]]]), 7, "Expected 7");
console.log(deepCount([[[[[[[[[]]]]]]]]]), 8, "Expected 8");
