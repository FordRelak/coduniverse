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
  spaceObject: Spaceobject | undefined;

  @Input()
  isCenterMass: boolean | undefined;

  @Output()
  eventRemove = new EventEmitter<string>();

  @Output()
  starEvent = new EventEmitter<string>();

  constructor() { }

  ngOnInit(): void {
    if (this.spaceObject != null)
      this.spaceObject!.isCenterMass = this.isCenterMass ?? false;
  }

  remove() {
    this.eventRemove.emit(this.spaceObject?.id);
  }

  makeCenterMass() {
    this.starEvent.emit(this.spaceObject?.id);
  }

  get isCenter(): boolean {
    return this.spaceObject?.isCenterMass ?? true
  }
}
