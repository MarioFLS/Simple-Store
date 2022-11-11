const formatDate = (dateString) => {
  const date = new Date(dateString);
  const mount = date.getMonth();
  const correctMonth = mount === 0 ? '01' : mount < 10 ? `0${mount}` : mount;
  const day = date.getDate();
  const correctDay = day < 10 ? `0${day}` : day;
  const year = date.getFullYear();

  return `${correctDay}/${correctMonth}/${year}`;
};

export default formatDate;
