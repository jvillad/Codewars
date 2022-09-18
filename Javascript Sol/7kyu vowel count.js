function getCount(str) {
   const count = str.match(/[aeiou]/gi);
    if (count === null)
      return 0;
    else
    return count.length;
}