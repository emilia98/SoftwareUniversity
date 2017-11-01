function checkValidity(array){
   let point0 = {x: 0, y: 0};
   let pointA = {x: Number(array[0]), y: Number(array[1])};
   let pointB = {x: Number(array[2]), y: Number(array[3])};

   checkForValidDistance(pointA, point0);
   checkForValidDistance(pointB, point0);
   checkForValidDistance(pointA, pointB);

   function checkForValidDistance(p1, p2){
       let distX = Math.abs(p1.x - p2.x);
       let distY = Math.abs(p1.y - p2.y);
       let distance = Math.sqrt(distX * distX + distY * distY);

       if(distance == parseInt(distance)){
           console.log(`{${p1.x}, ${p1.y}} to {${p2.x}, ${p2.y}} is valid`);
       }
       else{
           console.log(`{${p1.x}, ${p1.y}} to {${p2.x}, ${p2.y}} is invalid`);
       }
   }
}

/* Uncomment to test:
checkValidity([3, 0, 0, 4]);
checkValidity([2, 1, 1, 1]);
*/