import { Component, Injectable, Input, OnInit, Output } from '@angular/core';
import { EventEmitter } from '@angular/core';
import { StarSystem } from '../models/star-system';
import { SpaceObjectService } from '../services/space-object.service';
import { StarSystemService } from '../services/starsystem.service';

@Component({
  selector: 'app-star-system',
  templateUrl: './star-system.component.html',
  styleUrls: ['./star-system.component.scss']
})

@Injectable()
export class StarSystemComponent implements OnInit {

  @Input()
  starSystem!: StarSystem;

  @Output()
  deleteEvent = new EventEmitter<string>();

  constructor(
    private starSystemService: StarSystemService,
    private spaceObjectService: SpaceObjectService
  ) { }
  ngOnInit() {

  }

  removeObject(spaceObjectId: string) {
    if (spaceObjectId == this.starSystem.centerMass?.id) {
      alert("Select non center mass object");
      return;
    }
    this.spaceObjectService.delete(spaceObjectId).subscribe((data: any) => {
      let spaceObjectIndex = this.starSystem.spaceObjects.findIndex(x => x.id == spaceObjectId);
      if (spaceObjectIndex > -1) {
        this.starSystem.spaceObjects.splice(spaceObjectIndex, 1);
      }
    })
  }

  giveStar(spaceObjectId: string) {
    let data = { starSystemId: this.starSystem.id, spaceObjectId: spaceObjectId };
    this.starSystemService.makeCenterMass(data).subscribe((data: any) => {
      if (this.starSystem.centerMass != null) {
        this.starSystem.centerMass.isCenterMass = false;
      }
      this.starSystem.spaceObjects.forEach(x => x.isCenterMass = false);
      let spaceObject = this.starSystem.spaceObjects.find(x => x.id == spaceObjectId);
      if (spaceObject?.id === this.starSystem.centerMass?.id) {
        this.starSystem.centerMass.isCenterMass = true;
      }
      else if (spaceObject != null) {
        spaceObject.isCenterMass = true;
        this.starSystem.centerMass = spaceObject;
      }
    })
  }

  deleteStarSystem() {
    this.deleteEvent.emit(this.starSystem.id);
  }

}
