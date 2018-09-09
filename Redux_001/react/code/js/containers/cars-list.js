import React, {Component} from 'React';
import {bindActionCreators} from 'redux';
import {connect} from 'react-redux';

class CarsList extends Component{
  render(){
    return(
      <ol>
        <li>1</li>
        <li>2</li>
        <li>3</li>
      </ol>
    )
  }
}

export default CarsList;
