function getGrade (s1, s2, s3) {
  let avg = (s1+s2+s3) / 3;
  if(90 <= avg && avg <= 100)
    return "A";
  if(80 <= avg && avg <= 90)
     return "B";
  if(70 <= avg && avg <= 80)
     return "C";
  if(60 <= avg && avg <= 70)
     return "D";
  if(0 <= avg && avg <= 60)
    return "F"; //YIKES
  
 
}