function expressionMatter(a, b, c) {
  
  let arr = [];
  let sum = 0;
  sum = a * (b + c);
  arr.push(sum);
  sum = a * b * c;
  arr.push(sum);
  sum = a + b * c;
  arr.push(sum);
  sum = (a + b) * c;
  arr.push(sum);
  sum = a + b + c;
  arr.push(sum);
  
  return Math.max(...arr);

  
}