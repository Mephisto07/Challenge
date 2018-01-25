//https://www.hackerrank.com/challenges/js10-arrays/problem
function getSecondLargest(nums) {
    nums  = nums.sort(function(x, y) { return x < y; }); //sort desc
    nums = nums.filter(function(item,pos) { return nums.indexOf(item) == pos; }); //unique values
    
    return nums[1];
}

getSecondLargest([2,3,6,6,5]);
