let items=[];

function putItem(item){
    items.push(item)
}

//lamda way to cteate a method
const getAll = () => items;

const deleteItem = (index) => items.splice(index,1);

const updateItem = (index, item) => {
    items[index]=item;
}