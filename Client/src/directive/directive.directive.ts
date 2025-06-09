import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appDirective]',
  standalone: true
})
// שנוי עצוב עשינו כאשר לוחצים על מיון המוצרים
export class DirectiveDirective {
  
  constructor(private er: ElementRef) {
    let color ='black'
    // er.nativeElement.style.border = color + " 1px solid"
    er.nativeElement.style.color = color
   }
   @Input() newColor:string='red'
    @HostListener('click')
    a()
    {
    this.er.nativeElement.style.border = this.newColor + " 1px solid"
     this.er.nativeElement.style.color = this.newColor
    }
}