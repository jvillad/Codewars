function digitize(n) {
  
  
  const numArr = Array.from(String(n), Number);
  let revArr = [];
  for(let i = 1; i <= numArr.length; i++){
    revArr.push(numArr[numArr.length - i]);
  }
  
  return revArr;
  
}