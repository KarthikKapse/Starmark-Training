function storeBooks(){ 
    let books=[];
    let list=document.getElementById("list");
    let book= document.getElementById("bookName").value;
   books.push(book); 
   for(let index=0; index<books.length; index++){
       const favbooks = "<li>"+ books[index] +"</li>";
       list.innerHTML += favbooks;
   }
}