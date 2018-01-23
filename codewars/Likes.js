// 0 likes = 'no one likes this'
// 1 like = 'Peter likes this'
// 2 likes = 'Jacob and Alex like this'
// 3 likes = 'Max, John and Mark like this'
// More than 3 likes = 'Alex, Jacob and 2 others like this'

function likes(names){
  var msg = "";
  switch (names.length){
    case 0: msg = 'no one likes this'; break;
    case 1: msg = names[0] + " likes this"; break;
    case 2: msg = names[0] + " and " + names[1] + " like this"; break;
    case 3: msg = names[0] + ", " + names[1] + " and " + names[2] + " like this"; break;
    default: msg = names[0] + ", " + names[1] + " and " + (names.length - 2) + " others like this"; break;
  }
  
  return msg;
}

console.log(likes([]));
console.log(likes(['Peter']));
console.log(likes(['Jacob', 'Alex']));
console.log(likes(['Max', 'John', 'Mark']));
console.log(likes(['Alex', 'Jacob', 'Mark', 'Max']));
