let myModule = (function(){
   let counter = 0;

   function increase(num){
       counter += num;
   }

   function decrease(num){
       counter -= num;
   }

   function value() {
       return counter;
   }

   return{
       increase,
       decrease,
       value
   };
});

let newModule = myModule();
newModule.increase(5);
newModule.decrease(-3);
console.log(newModule.value());