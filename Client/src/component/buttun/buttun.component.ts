import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-buttun',
  standalone: true,
  imports: [],
  templateUrl: './buttun.component.html',
  styleUrl: './buttun.component.css'
})
export class ButtunComponent {
//קומפוננטת בן
//מבנה מסוים של כפתור עם אייקון
  @Input() icon: string|undefined
  @Input() word: string|undefined
  @Input() class: string|undefined
  @Input() disabled: boolean = false; 


}
