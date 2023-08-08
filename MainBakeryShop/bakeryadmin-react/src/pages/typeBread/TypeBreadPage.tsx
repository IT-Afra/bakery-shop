import React from 'react'
import { Spin, Row, Col, Table, Grid, Button } from 'antd'
import { ITypeBread } from '../../models/ITypeBread'
import type { ColumnsType } from 'antd/es/table';
import { EditFilled } from "@ant-design/icons";
import axios from 'axios'
const { useBreakpoint } = Grid;

type Props = {}

const TypeBreadPage = (props: Props) => {
  const [isSpinning, setIsSpinning] = React.useState(true)
  const [typeBreads, setTypeBreads] = React.useState<ITypeBread[]>([])
  const screens = useBreakpoint();
  const [selectedRowKeys, setSelectedRowKeys] = React.useState<React.Key[]>([]);
  const [selectedRowID, setSelectedRowID] = React.useState<React.Key[]>([0]);

  const getTypeBreads = () => {
    axios.get<ITypeBread[]>('https://localhost:7239/api/typeBread')
      .then(function (response) {
        setTypeBreads(response.data)
      })
      .catch(function (error) {
        // handle error
        console.log(error);
      })
      .finally(function () {
        setIsSpinning(false)
      });
  }

  React.useEffect(() => {
    getTypeBreads();
  }, [typeBreads]);


  const save = (typeBread: ITypeBread) => {
    axios.post<ITypeBread>("https://localhost:7239/api/typeBread", {
      id: typeBread.id,
      name: typeBread.name,
      isActive: typeBread.isActive,
      photoGuid: typeBread.photoGuid
    })
      .then((response) => {
        setIsSpinning(true);
        let data: ITypeBread[] = [response.data, ...typeBreads];
        setTypeBreads(data);
      })
      .catch((error) => {
        // handle error
        console.log(error);
      })
      .finally(() => {
        setIsSpinning(false)
      });
  }

  const onSelectChange = (newSelectedRowKeys: React.Key[], selectedRow: ITypeBread[]) => {
    let ids = selectedRow.map((x) => {
      return (x.id);
    });
    setSelectedRowID(ids)
    setSelectedRowKeys(newSelectedRowKeys);
  };
  const rowSelection = {
    selectedRowKeys,
    onChange: onSelectChange,
  };

  const columnsMobile: ColumnsType<ITypeBread> = [
    {
      title: "لیست نان های موجود",
      dataIndex: "Bread",
      render: (record: ITypeBread) => (
        <div>
          <span>
            <div style={{ width: "25%" }}>ردیف : </div>
            <div style={{ width: "75%", fontWeight: "bold" }}>{record.id}</div >
          </span>
          <span>
            <div style={{ width: "25%" }}>نام : </div>
            <div style={{ width: "75%", fontWeight: "bold" }}>{record.name}</div >
          </span>
          <span>
            <div style={{ width: "25%" }}>وضعیت : </div>
            <div style={{ width: "75%", fontWeight: "bold" }}>{record.isActive}</div >
          </span>
          <span>
            <div style={{ width: "25%" }}>عکس : </div>
            <div style={{ width: "75%", fontWeight: "bold" }}>{record.photoGuid}</div >
          </span>
          <span>
            <div style={{ width: "25%" }}>ویرایش : </div>
            <Button icon={<EditFilled />} onClick={() => save(record)}></Button>
            <div style={{ width: "75%", fontWeight: "bold" }}>
            </div >
          </span>
        </div>
      )
    }]

  const columns: ColumnsType<ITypeBread> = [
    {
      title: 'ردیف',
      dataIndex: 'id',
    },
    {
      title: 'عنوان',
      dataIndex: 'name',
    },
    {
      title: 'وضعیت',
      dataIndex: 'isActive',
      render: (isActive: boolean) => isActive ? "فعال" : "غیرفعال"
    },
    {
      title: 'عکس',
      dataIndex: 'photoGuid',
    },
    {
      title: 'ویرایش',
      dataIndex: 'id',
      render: (record: ITypeBread) => <Button icon={<EditFilled />} onClick={() => save(record)}></Button>
    }
  ]

  return (
    <Spin spinning={isSpinning}>
      <Row>
        <Col span={5}>
          انواع نان
        </Col>
      </Row>
      <Table rowSelection={rowSelection} columns={screens.xs ? columnsMobile : columns} dataSource={typeBreads} />
    </Spin>
  )
}

export default TypeBreadPage