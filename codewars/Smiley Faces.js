// Description: https://www.codewars.com/kata/count-the-smiley-faces

function countSmileys(arr) {
  var count = 0;
  for(var i = 0; i < arr.length; i++){
    if (/(\:|\;)(\~|\-)?(\)|[D])/.test(arr[i])){
      count++;
    }
  }
  return count;
}

console.log(countSmileys([]));
console.log(countSmileys([':D',':~)',';~D',':)']));
console.log(countSmileys([':)',':(',':D',':O',':;']));
console.log(countSmileys([';]', ':[', ';*', ':$', ';-D']));
