
export function getPositionElement(value){
    //console.log(value);
    return value.getBoundingClientRect().top;
}
export function getScrollY(){
    //console.log(value);
    return window.scrollY;
}