
function stantonMeasure(numArr) {
  let firstVal = 1;
  let secondVal = 0;
  for (num of numArr) {
    if (num == firstVal) {
          secondVal++;
      }
  };
  let target = 0;
  for (num of numArr) {
    if (num == secondVal) {
    target++;
    }
  };
  
  return target;
}
