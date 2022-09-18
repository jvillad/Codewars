function getMiddle(s)
{
  
    let mid = s.length/2;
    if(s.length%2 === 0) {
      return s.substring(mid-1, mid) + s.substring(mid, mid+1);
   
    } else {
     return s.substring(mid, mid+1);
    }
   
  
}