import { Component, Input, OnInit, Output } from '@angular/core';
import { EventEmitter } from '@angular/core';
import { Spaceobject } from '../models/spaceobject';

@Component({
  selector: 'app-spaceobject',
  templateUrl: './spaceobject.component.html',
  styleUrls: ['./spaceobject.component.scss'],
})
export class SpaceobjectComponent implements OnInit {

  @Input()
  spaceObject!: Spaceobject;

  @Output()
  eventRemove = new EventEmitter<string>();

  constructor() { }

  ngOnInit(): void {
  }

  remove() {
    this.eventRemove.emit(this.spaceObject.id);
  }
}
